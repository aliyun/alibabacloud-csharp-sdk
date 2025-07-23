// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateDeploymentJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate. Separate multiple certificate IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a> operation to obtain the IDs of certificates from the <b>CertificateId</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12342649,12304338,12067351,9957285</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <para>The ID of the contact. Separate multiple contact IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/2712221.html">ListContact</a> operation to obtain the IDs of contacts from the <b>ContactId</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// <para>The type of the deployment task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: multi-cloud deployment task.</description></item>
        /// <item><description>user: cloud service deployment task. This type of task does not support cloud servers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The name of the deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource. Separate multiple resource IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/2712230.html">ListCloudResources</a> operation to obtain the IDs of cloud resources from the <b>Id</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6591316,6585549,6190248,5811894,5775176,5772504</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The time when the task starts. The value is a UNIX timestamp. If you do not specify this parameter, the system immediately starts the task after the task is in the pending state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706613560008</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

    }

}
