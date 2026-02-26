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
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pc-xxxxxx</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

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
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        [NameInMap("NetType")]
                        [Validation(Required=false)]
                        public string NetType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("PolarFSInstanceId")]
                [Validation(Required=false)]
                public string PolarFSInstanceId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeApplicationsResponseBodyItemsApplicationsTags Tags { get; set; }
                public class DescribeApplicationsResponseBodyItemsApplicationsTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationsResponseBodyItemsApplicationsTagsTag> Tag { get; set; }
                    public class DescribeApplicationsResponseBodyItemsApplicationsTagsTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>testKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>testValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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
