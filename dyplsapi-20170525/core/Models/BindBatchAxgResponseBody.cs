// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindBatchAxgResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5DCCA8CD-6C0A-50B4-A496-B1D2AB48A1C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretBindList")]
        [Validation(Required=false)]
        public BindBatchAxgResponseBodySecretBindList SecretBindList { get; set; }
        public class BindBatchAxgResponseBodySecretBindList : TeaModel {
            [NameInMap("SecretBind")]
            [Validation(Required=false)]
            public List<BindBatchAxgResponseBodySecretBindListSecretBind> SecretBind { get; set; }
            public class BindBatchAxgResponseBodySecretBindListSecretBind : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>isv.INVALID_PARAMETERS</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>257</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ringConfig invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13333333333</para>
                /// </summary>
                [NameInMap("PhoneNoA")]
                [Validation(Required=false)]
                public string PhoneNoA { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13333333333</para>
                /// </summary>
                [NameInMap("SecretNo")]
                [Validation(Required=false)]
                public string SecretNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000085060515673</para>
                /// </summary>
                [NameInMap("SubsId")]
                [Validation(Required=false)]
                public string SubsId { get; set; }

            }

        }

    }

}
