// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaInstancesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the SAP HANA instances.
        /// </summary>
        [NameInMap("Hanas")]
        [Validation(Required=false)]
        public DescribeHanaInstancesResponseBodyHanas Hanas { get; set; }
        public class DescribeHanaInstancesResponseBodyHanas : TeaModel {
            [NameInMap("Hana")]
            [Validation(Required=false)]
            public List<DescribeHanaInstancesResponseBodyHanasHana> Hana { get; set; }
            public class DescribeHanaInstancesResponseBodyHanasHana : TeaModel {
                /// <summary>
                /// The alert settings. Valid value: INHERITED, which indicates that the backup client sends alert notifications in the same way as the backup vault.
                /// </summary>
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                /// <summary>
                /// The ID of the SAP HANA instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the SAP HANA instance.
                /// </summary>
                [NameInMap("HanaName")]
                [Validation(Required=false)]
                public string HanaName { get; set; }

                /// <summary>
                /// The private or internal IP address of the host where the primary node of the SAP HANA instance resides.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The instance number of the SAP HANA system.
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                /// <summary>
                /// The ID of resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the SAP HANA instance. Valid values:
                /// 
                /// *   INITIALIZING: The instance is being initialized.
                /// *   INITIALIZED: The instance is registered.
                /// *   INVALID_HANA_NODE: The instance is invalid.
                /// *   INITIALIZE_FAILED: The client fails to be installed on the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// The status information.
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                /// <summary>
                /// The tags of the SAP HANA instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHanaInstancesResponseBodyHanasHanaTags Tags { get; set; }
                public class DescribeHanaInstancesResponseBodyHanasHanaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHanaInstancesResponseBodyHanasHanaTagsTag> Tag { get; set; }
                    public class DescribeHanaInstancesResponseBodyHanasHanaTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the SAP HANA instance is connected over Secure Sockets Layer (SSL). Valid values:
                /// 
                /// *   true: The SAP HANA instance is connected over SSL.
                /// *   false: The SAP HANA instance is not connected over SSL.
                /// </summary>
                [NameInMap("UseSsl")]
                [Validation(Required=false)]
                public bool? UseSsl { get; set; }

                /// <summary>
                /// The username of the SYSTEMDB database.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// Indicates whether the SSL certificate of the SAP HANA instance is verified.
                /// </summary>
                [NameInMap("ValidateCertificate")]
                [Validation(Required=false)]
                public bool? ValidateCertificate { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
