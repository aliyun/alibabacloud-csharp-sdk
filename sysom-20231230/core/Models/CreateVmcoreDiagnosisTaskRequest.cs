// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateVmcoreDiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The download URL of the debuginfo-common file. This parameter is optional when the diagnostic type is vmcore.</para>
        /// <para>For CentOS or Alinux kernels, the corresponding debuginfo-common file is automatically downloaded, and you do not need to specify this parameter. For other distribution kernels, manually provide the download URL of the debuginfo-common file that corresponds to the kernel version.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoCommonUrl")]
        [Validation(Required=false)]
        public string DebuginfoCommonUrl { get; set; }

        /// <summary>
        /// <para>The download URL of the debuginfo file. This parameter is optional when the diagnostic type is vmcore.</para>
        /// <para>For CentOS or Alinux kernels, the corresponding debuginfo file is automatically downloaded, and you do not need to specify this parameter. For other distribution kernels, manually provide the download URL of the debuginfo file that corresponds to the kernel version.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoUrl")]
        [Validation(Required=false)]
        public string DebuginfoUrl { get; set; }

        /// <summary>
        /// <para>The download URL of the dmesg log file. This parameter is required when the diagnostic type is dmesg.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path</a></para>
        /// </summary>
        [NameInMap("dmesgUrl")]
        [Validation(Required=false)]
        public string DmesgUrl { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vmcore: vmcore file diagnostic task.</description></item>
        /// <item><description>dmesg: dmesg log diagnostic task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vmcore</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The download URL of the vmcore file. This parameter is required when the diagnostic type is vmcore.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path</a></para>
        /// </summary>
        [NameInMap("vmcoreUrl")]
        [Validation(Required=false)]
        public string VmcoreUrl { get; set; }

    }

}
