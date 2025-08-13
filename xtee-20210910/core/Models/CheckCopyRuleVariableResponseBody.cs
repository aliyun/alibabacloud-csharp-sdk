// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CheckCopyRuleVariableResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CheckCopyRuleVariableResponseBodyResultObject ResultObject { get; set; }
        public class CheckCopyRuleVariableResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Information.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<CheckCopyRuleVariableResponseBodyResultObjectMessage> Message { get; set; }
            public class CheckCopyRuleVariableResponseBodyResultObjectMessage : TeaModel {
                /// <summary>
                /// <para>Primary key ID of the variable</para>
                /// 
                /// <b>Example:</b>
                /// <para>213</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Name of the variable</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Title of the variable</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Type of the variable</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
