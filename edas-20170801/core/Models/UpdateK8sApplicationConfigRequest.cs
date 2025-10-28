// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sApplicationConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can query the application ID by calling the ListApplication operation. For more information, see <a href="https://help.aliyun.com/document_detail/423162.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23bf94d9-****-4994-9917-616a827aa777</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. You can query the cluster ID by calling the ListCluster operation. For more information, see <a href="https://help.aliyun.com/document_detail/411844.html">ListCluster</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c28bbb9-****-44b3-b953-54ef8a2d0be2</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed for each application instance when the application is running. The value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested for each application instance when the application is running. Unit: cores. We recommend that you set this parameter. The value 0 indicates that no limit is set on CPU cores.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public string CpuRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("EphemeralStorageLimit")]
        [Validation(Required=false)]
        public string EphemeralStorageLimit { get; set; }

        /// <summary>
        /// <para>The minimum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the EphemeralStorageLimit parameter. Make sure that the value of this parameter does not exceed that of the EphemeralStorageLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EphemeralStorageRequest")]
        [Validation(Required=false)]
        public string EphemeralStorageRequest { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores allowed. The value 0 indicates that no limit is set on CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public string McpuLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores required. Unit: cores. The value 0 indicates that no limit is set on CPU cores.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public string McpuRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of memory allowed for each application instance when the application is running. Unit: MB. The value 0 indicates that no limit is set on the memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// <para>The size of memory requested for each application instance when the application is running. Unit: MB. We recommend that you set this parameter. If you do not want to apply for a memory quota, set this parameter to 0.</para>
        /// <remarks>
        /// <para>You must set this parameter together with the MemoryLimit parameter. Make sure that the value of this parameter does not exceed that of the MemoryLimit parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public string MemoryRequest { get; set; }

        /// <summary>
        /// <para>The timeout period of the change process. Valid values: 1 to 1800. Default value: 600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
