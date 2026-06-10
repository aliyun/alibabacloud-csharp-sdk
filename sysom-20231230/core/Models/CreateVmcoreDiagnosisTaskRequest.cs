// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateVmcoreDiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>Download link for the debuginfo-common file. This parameter is optional when the diagnosis type is vmcore.  </para>
        /// <para>For CentOS or Alinux kernel diagnosis, the corresponding debuginfo-common file is automatically downloaded, so you do not need to provide this parameter. For kernels of other distributions, you must manually provide the download link for the debuginfo-common file that matches the kernel version.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoCommonUrl")]
        [Validation(Required=false)]
        public string DebuginfoCommonUrl { get; set; }

        /// <summary>
        /// <para>The download link of the debuginfo file corresponding to the vmcore file. This parameter is optional when the diagnosis type is vmcore.</para>
        /// <para>For CentOS or Alinux kernel diagnosis, the corresponding debuginfo file is automatically downloaded, so you do not need to provide this parameter. For kernels from other distributions, you must manually provide the download link for the debuginfo file that matches the kernel version.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoUrl")]
        [Validation(Required=false)]
        public string DebuginfoUrl { get; set; }

        /// <summary>
        /// <para>Download link for the dmesg log file. This parameter is required when the diagnosis type is dmesg.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path</a></para>
        /// </summary>
        [NameInMap("dmesgUrl")]
        [Validation(Required=false)]
        public string DmesgUrl { get; set; }

        /// <summary>
        /// <para>Task Type  </para>
        /// <para>vmcore: vmcore file diagnosis task  </para>
        /// <para>dmesg: dmesg log diagnosis task</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vmcore</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The download link of the vmcore file. This parameter is required when the diagnosis type is vmcore.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path</a></para>
        /// </summary>
        [NameInMap("vmcoreUrl")]
        [Validation(Required=false)]
        public string VmcoreUrl { get; set; }

    }

}
