// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeApplicationsResponseBodyItems Items { get; set; }
        public class DescribeApplicationsResponseBodyItems : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<DescribeApplicationsResponseBodyItemsApplications> Applications { get; set; }
            public class DescribeApplicationsResponseBodyItemsApplications : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-**************</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-25T09:37:10Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>myapp</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Endpoints")]
                [Validation(Required=false)]
                public DescribeApplicationsResponseBodyItemsApplicationsEndpoints Endpoints { get; set; }
                public class DescribeApplicationsResponseBodyItemsApplicationsEndpoints : TeaModel {
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationsResponseBodyItemsApplicationsEndpointsEndpoint> Endpoint { get; set; }
                    public class DescribeApplicationsResponseBodyItemsApplicationsEndpointsEndpoint : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>192.168.0.3</para>
                        /// </summary>
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Public</para>
                        /// </summary>
                        [NameInMap("NetType")]
                        [Validation(Required=false)]
                        public string NetType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>8080</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-25T09:37:10Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pcs-**************</para>
                /// </summary>
                [NameInMap("PolarFSInstanceId")]
                [Validation(Required=false)]
                public string PolarFSInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
