// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumAppInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumAppInfoResponseBodyData Data { get; set; }
        public class GetRumAppInfoResponseBodyData : TeaModel {
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }

            /// <summary>
            /// The application type. Valid values: web, miniapp, ios, and android.
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("BonreeSDKConfig")]
            [Validation(Required=false)]
            public GetRumAppInfoResponseBodyDataBonreeSDKConfig BonreeSDKConfig { get; set; }
            public class GetRumAppInfoResponseBodyDataBonreeSDKConfig : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("moduleConfig")]
                [Validation(Required=false)]
                public Dictionary<string, DataBonreeSDKConfigModuleConfigValue> ModuleConfig { get; set; }

            }

            [NameInMap("CdnDomain")]
            [Validation(Required=false)]
            public string CdnDomain { get; set; }

            /// <summary>
            /// The time when the application was created. The value is a timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The endpoint that is used to report application data.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// Indicates whether the application is subscribed. Valid values: true and false.
            /// </summary>
            [NameInMap("IsSubscription")]
            [Validation(Required=false)]
            public string IsSubscription { get; set; }

            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The alias of the application.
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The name of the application package.
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Service domain name configuration list (currently only supports mobile applications).
            /// </summary>
            [NameInMap("ServiceDomainConfigs")]
            [Validation(Required=false)]
            public List<GetRumAppInfoResponseBodyDataServiceDomainConfigs> ServiceDomainConfigs { get; set; }
            public class GetRumAppInfoResponseBodyDataServiceDomainConfigs : TeaModel {
                /// <summary>
                /// Describe.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Domain name or IP.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// Trace transparent transmission protocol list, must be transmitted when link tracking is enabled.
                /// </summary>
                [NameInMap("PropagatorTypes")]
                [Validation(Required=false)]
                public List<string> PropagatorTypes { get; set; }

                /// <summary>
                /// Whether to enable link tracking (need to enable the observable link Open Telemetry version), value:
                /// - `true`: Enable link tracking (after enabling, the relevant header will be inserted into the domain name request).
                /// - `false`: Do not enable link tracking.
                /// </summary>
                [NameInMap("Tracing")]
                [Validation(Required=false)]
                public bool? Tracing { get; set; }

            }

            /// <summary>
            /// The name of the Simple Log Service Logstore that stores application data.
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// The name of the Simple Log Service project that stores application data.
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// The status of the application. Valid values: created, running, and stopped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetRumAppInfoResponseBodyDataTags> Tags { get; set; }
            public class GetRumAppInfoResponseBodyDataTags : TeaModel {
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

            /// <summary>
            /// The type of the application. Valid value: RUM.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
