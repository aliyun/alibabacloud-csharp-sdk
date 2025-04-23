// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the command.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87388.html">ListCommands</a> operation to query the command ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz01v8x80o3****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The information of nodes on which the command is run.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<ListInvocationResultsRequestInstance> Instance { get; set; }
        public class ListInvocationResultsRequestInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the node on which the command is run.</para>
            /// <remarks>
            /// <para> The Instance.N.Id parameter specifies the node on which the command is run. If it is not specified, the command is run on all nodes of the cluster.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf65bh2113hlqvyr****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The status of the command that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Stopped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Page numbers start from 1.</para>
        /// <para>Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 50.</para>
        /// <para>Default value: 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
