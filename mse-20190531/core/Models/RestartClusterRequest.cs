// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class RestartClusterRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the pod. You can specify the names of multiple pods at a time. Separate multiple pod names with commas (,).
        /// Example: mse-a8aba010-1629719288255-reg-center-0-1,mse-a8aba010-1629719288255-reg-center-0-2.
        /// 
        /// The specified pods must belong to the current cluster and be associated with the specified instance. Otherwise, a restart exception occurs.
        /// </summary>
        [NameInMap("PodNameList")]
        [Validation(Required=false)]
        public string PodNameList { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
