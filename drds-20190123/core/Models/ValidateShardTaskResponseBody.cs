// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ValidateShardTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the check results.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ValidateShardTaskResponseBodyList> List { get; set; }
        public class ValidateShardTaskResponseBodyList : TeaModel {
            /// <summary>
            /// <para>Indicates the name of a check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>same_schema</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>Indicates the result of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: indicates the task is valid.</description></item>
            /// <item><description><b>1</b>: indicates the task is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B6B7BDC-575D-4A77-A4F8-24B7EFAS45FG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
