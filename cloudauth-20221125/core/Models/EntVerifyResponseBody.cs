// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntVerifyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-A***B-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EntVerifyResponseBodyResult Result { get; set; }
        public class EntVerifyResponseBodyResult : TeaModel {
            [NameInMap("RiskVerifyResult")]
            [Validation(Required=false)]
            public EntVerifyResponseBodyResultRiskVerifyResult RiskVerifyResult { get; set; }
            public class EntVerifyResponseBodyResultRiskVerifyResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Found")]
                [Validation(Required=false)]
                public bool? Found { get; set; }

                [NameInMap("ModelResults")]
                [Validation(Required=false)]
                public List<EntVerifyResponseBodyResultRiskVerifyResultModelResults> ModelResults { get; set; }
                public class EntVerifyResponseBodyResultRiskVerifyResultModelResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>model_1</para>
                    /// </summary>
                    [NameInMap("ModelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                }

            }

        }

    }

}
