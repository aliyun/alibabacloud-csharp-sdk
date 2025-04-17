// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class GetListenerHealthStatusRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. You can specify at most 20 filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusRequestFilter> Filter { get; set; }
        public class GetListenerHealthStatusRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition name. You can filter by one or more filter condition names. The URL must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><b>Status</b>: the health status.</description></item>
            /// <item><description><b>ReasonCode</b>: the cause of an unhealthy server.</description></item>
            /// <item><description><b>ServerId</b>: the ID of the backend server.</description></item>
            /// <item><description><b>ServerIp</b>: the IP address of the backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Status</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter condition values. You can specify at most 20 condition values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-7sixpvm5fc3v0b****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4f1d7cc9f51e18904e8a063603a6b0c3d03bc69f78734254e0b5e8707e68****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to be skipped in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

    }

}
