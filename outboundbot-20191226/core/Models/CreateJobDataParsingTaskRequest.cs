// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobDataParsingTaskRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3865dc3-40fa-4afd-9fe4-dc7cda305a24</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Path to the file that contains the job data.</para>
        /// <remarks>
        /// <para>This value is the Folder parameter returned by the GetJobDataUploadParams operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPLOADED/JOB/024f8cf0-c842-4c01-b74b-c8667e4579c7/e5897675-91f0-4e53-8af8-7e1ce4f2c089_KDC HR- 外呼话术2- 外呼名单模板 - Copy.xlsx</para>
        /// </summary>
        [NameInMap("JobFilePath")]
        [Validation(Required=false)]
        public string JobFilePath { get; set; }

    }

}
