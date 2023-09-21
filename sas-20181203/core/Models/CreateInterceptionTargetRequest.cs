// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateInterceptionTargetRequest : TeaModel {
        /// <summary>
        /// The name of the application to which the network object belongs.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The cluster name.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// An array that consists of the images of the network object.
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// The namespace to which the network object belongs.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// An array that consists of the labels specified for the network object.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// The name of the object to be blocked.
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// The object type. Valid value:
        /// 
        /// *   **IMAGE**
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
