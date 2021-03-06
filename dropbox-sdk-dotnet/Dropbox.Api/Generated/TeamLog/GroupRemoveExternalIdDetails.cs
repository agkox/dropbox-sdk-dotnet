// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Removed the external ID for group.</para>
    /// </summary>
    public class GroupRemoveExternalIdDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupRemoveExternalIdDetails> Encoder = new GroupRemoveExternalIdDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupRemoveExternalIdDetails> Decoder = new GroupRemoveExternalIdDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupRemoveExternalIdDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="previousValue">Old external id.</param>
        public GroupRemoveExternalIdDetails(string previousValue)
        {
            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupRemoveExternalIdDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupRemoveExternalIdDetails()
        {
        }

        /// <summary>
        /// <para>Old external id.</para>
        /// </summary>
        public string PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupRemoveExternalIdDetails" />.</para>
        /// </summary>
        private class GroupRemoveExternalIdDetailsEncoder : enc.StructEncoder<GroupRemoveExternalIdDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupRemoveExternalIdDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_value", value.PreviousValue, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupRemoveExternalIdDetails" />.</para>
        /// </summary>
        private class GroupRemoveExternalIdDetailsDecoder : enc.StructDecoder<GroupRemoveExternalIdDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupRemoveExternalIdDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupRemoveExternalIdDetails Create()
            {
                return new GroupRemoveExternalIdDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupRemoveExternalIdDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_value":
                        value.PreviousValue = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
