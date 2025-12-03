// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateVmcoreDiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo-common/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoCommonUrl")]
        [Validation(Required=false)]
        public string DebuginfoCommonUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/debuginfo/file/path</a></para>
        /// </summary>
        [NameInMap("debuginfoUrl")]
        [Validation(Required=false)]
        public string DebuginfoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/dmesg/file/path</a></para>
        /// </summary>
        [NameInMap("dmesgUrl")]
        [Validation(Required=false)]
        public string DmesgUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vmcore</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path">https://bucket-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/vmcore/file/path</a></para>
        /// </summary>
        [NameInMap("vmcoreUrl")]
        [Validation(Required=false)]
        public string VmcoreUrl { get; set; }

    }

}
