// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetIpfilterListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>84DD77C7-A091-5139-9530-2D1F7CCE59E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Data records</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIpfilterListResponseBodyData Data { get; set; }
        public class GetIpfilterListResponseBodyData : TeaModel {
            [NameInMap("ipfilters")]
            [Validation(Required=false)]
            public List<GetIpfilterListResponseBodyDataIpfilters> Ipfilters { get; set; }
            public class GetIpfilterListResponseBodyDataIpfilters : TeaModel {
                /// <summary>
                /// <para>timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>1653547140</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Record ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>10083</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>IP address/IP range/IP segment</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.xxx
                /// xxx.xxx.xxx.xxx-xxx.xxx.xxx.xxx
                /// xxx.xxx.xxx.xxx/xxx</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

            }

        }

    }

}
