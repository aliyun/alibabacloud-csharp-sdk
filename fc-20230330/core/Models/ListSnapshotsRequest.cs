// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-func</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The maximum number of snapshots to return. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0be03****f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The function alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The source session ID from which the snapshot was created. When specified, functionName must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session-id-1</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
