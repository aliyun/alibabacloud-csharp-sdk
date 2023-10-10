// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the instance group where the application is deployed. You can call the ListDeployGroup operation to query the group ID. For more information, see [ListDeployGroup](~~62077~~).
        /// 
        /// > 
        /// 
        /// *   To configure the JVM parameters for an instance group, set this parameter to a specific ID.
        /// 
        /// *   To configure the JVM parameters for an application, leave this parameter empty.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The maximum size of the heap memory. Unit: MB.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified in the group configuration, the value specified in the application configuration is used.
        /// 
        /// *   If this parameter is not specified in the application configuration, the default value is used.
        /// </summary>
        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

        /// <summary>
        /// The size of the permanent generation heap memory. Unit: MB.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified in the group configuration, the value specified in the application configuration is used.
        /// 
        /// *   If this parameter is not specified in the application configuration, the default value is used.
        /// </summary>
        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        /// <summary>
        /// The initial size of the heap memory. Unit: MB.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified in the group configuration, the value specified in the application configuration is used.
        /// 
        /// *   If this parameter is not specified in the application configuration, the default value is used.
        /// </summary>
        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        /// <summary>
        /// The custom JVM parameters.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified in the group configuration, the value specified in the application configuration is used.
        /// 
        /// *   If this parameter is not specified in the application configuration, the default value is used.
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

    }

}
