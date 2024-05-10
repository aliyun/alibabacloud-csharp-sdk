// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyInterceptionTargetRequest : TeaModel {
        /// <summary>
        /// The name of the application.
        /// 
        /// > You can call the [DescribeContainerTags](~~DescribeContainerTags~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// An array that consists of images.
        /// 
        /// > You can call the [DescribeContainerTags](~~DescribeContainerTags~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// The namespace.
        /// 
        /// > You can call the [DescribeContainerTags](~~DescribeContainerTags~~) operation to obtain the value of this parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// An array that consists of tags.
        /// 
        /// > You can call the [DescribeContainerTags](~~DescribeContainerTags~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// The ID of the network object.
        /// 
        /// > You can call the [ListInterceptionTargetPage](~~ListInterceptionTargetPage~~) operation to obtain the value of this parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

        /// <summary>
        /// The name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// The object type. Valid values:
        /// 
        /// *   **IMAGE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
