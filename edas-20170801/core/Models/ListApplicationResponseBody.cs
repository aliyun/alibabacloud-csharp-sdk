// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationResponseBody : TeaModel {
        [NameInMap("ApplicationList")]
        [Validation(Required=false)]
        public ListApplicationResponseBodyApplicationList ApplicationList { get; set; }
        public class ListApplicationResponseBodyApplicationList : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationResponseBodyApplicationListApplication> Application { get; set; }
            public class ListApplicationResponseBodyApplicationListApplication : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public long? BuildPackageId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ExtSlbIp")]
                [Validation(Required=false)]
                public string ExtSlbIp { get; set; }

                [NameInMap("ExtSlbListenerPort")]
                [Validation(Required=false)]
                public int? ExtSlbListenerPort { get; set; }

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                [NameInMap("SlbIp")]
                [Validation(Required=false)]
                public string SlbIp { get; set; }

                [NameInMap("SlbListenerPort")]
                [Validation(Required=false)]
                public int? SlbListenerPort { get; set; }

                [NameInMap("SlbPort")]
                [Validation(Required=false)]
                public int? SlbPort { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d6fa0bc-cc3**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
