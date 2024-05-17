// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupRequest : TeaModel {
        /// <summary>
        /// The AppKey for the application.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// The name of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用类型。
        /// 
        /// - 1、普通应用。
        /// - 2、k8s应用。
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public int? AppType { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 是否开启日志。
        /// 
        /// - true：开启
        /// 
        /// - false：关闭
        /// </summary>
        [NameInMap("EnableLog")]
        [Validation(Required=false)]
        public bool? EnableLog { get; set; }

        /// <summary>
        /// The application ID. You can obtain the application ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The maximum number of jobs.
        /// </summary>
        [NameInMap("MaxJobs")]
        [Validation(Required=false)]
        public int? MaxJobs { get; set; }

        /// <summary>
        /// The configuration of the alert. The value is a JSON string. For more information about this parameter, see **Additional information about request parameters**.
        /// </summary>
        [NameInMap("MonitorConfigJson")]
        [Validation(Required=false)]
        public string MonitorConfigJson { get; set; }

        /// <summary>
        /// The configuration of alert contacts. The value is a JSON string.
        /// </summary>
        [NameInMap("MonitorContactsJson")]
        [Validation(Required=false)]
        public string MonitorContactsJson { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// This parameter is not supported. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to schedule a busy worker.
        /// </summary>
        [NameInMap("ScheduleBusyWorkers")]
        [Validation(Required=false)]
        public bool? ScheduleBusyWorkers { get; set; }

    }

}
