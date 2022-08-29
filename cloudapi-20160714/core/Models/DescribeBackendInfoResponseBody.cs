// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeBackendInfoResponseBody : TeaModel {
        [NameInMap("BackendInfo")]
        [Validation(Required=false)]
        public DescribeBackendInfoResponseBodyBackendInfo BackendInfo { get; set; }
        public class DescribeBackendInfoResponseBodyBackendInfo : TeaModel {
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }
            [NameInMap("BackendModels")]
            [Validation(Required=false)]
            public List<DescribeBackendInfoResponseBodyBackendInfoBackendModels> BackendModels { get; set; }
            public class DescribeBackendInfoResponseBodyBackendInfoBackendModels : TeaModel {
                public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig BackendConfig { get; set; }
                public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfig : TeaModel {
                    [NameInMap("EventBridgeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig EventBridgeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigEventBridgeConfig : TeaModel {
                        [NameInMap("EventBridgeRegionId")]
                        [Validation(Required=false)]
                        public string EventBridgeRegionId { get; set; }
                        [NameInMap("EventBus")]
                        [Validation(Required=false)]
                        public string EventBus { get; set; }
                        [NameInMap("EventSource")]
                        [Validation(Required=false)]
                        public string EventSource { get; set; }
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }
                    };

                    [NameInMap("FunctionComputeConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig FunctionComputeConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigFunctionComputeConfig : TeaModel {
                        [NameInMap("FcBaseUrl")]
                        [Validation(Required=false)]
                        public string FcBaseUrl { get; set; }
                        [NameInMap("FcRegionId")]
                        [Validation(Required=false)]
                        public string FcRegionId { get; set; }
                        [NameInMap("FcType")]
                        [Validation(Required=false)]
                        public string FcType { get; set; }
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public string FunctionName { get; set; }
                        [NameInMap("OnlyBusinessPath")]
                        [Validation(Required=false)]
                        public bool? OnlyBusinessPath { get; set; }
                        [NameInMap("Qualifier")]
                        [Validation(Required=false)]
                        public string Qualifier { get; set; }
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }
                    };

                    [NameInMap("OssConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig OssConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigOssConfig : TeaModel {
                        [NameInMap("BucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }
                        [NameInMap("OssRegionId")]
                        [Validation(Required=false)]
                        public string OssRegionId { get; set; }
                    };

                    [NameInMap("ServiceAddress")]
                    [Validation(Required=false)]
                    public string ServiceAddress { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("VpcConfig")]
                    [Validation(Required=false)]
                    public DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig VpcConfig { get; set; }
                    public class DescribeBackendInfoResponseBodyBackendInfoBackendModelsBackendConfigVpcConfig : TeaModel {
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }
                        [NameInMap("VpcAccessId")]
                        [Validation(Required=false)]
                        public string VpcAccessId { get; set; }
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }
                        [NameInMap("VpcScheme")]
                        [Validation(Required=false)]
                        public string VpcScheme { get; set; }
                        [NameInMap("VpcTargetHostName")]
                        [Validation(Required=false)]
                        public string VpcTargetHostName { get; set; }
                    };

                }
                public string BackendModelId { get; set; }
                public string Description { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string StageModeId { get; set; }
                public string StageName { get; set; }
            }
            [NameInMap("BackendName")]
            [Validation(Required=false)]
            public string BackendName { get; set; }
            [NameInMap("BackendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
