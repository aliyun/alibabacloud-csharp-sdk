// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateDeploymentJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate. Separate multiple certificate IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a> operation to obtain the ID of a certificate from the <b>CertificateId</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9957285,12067351,12304338,12342649</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <para>The ID of the contact. Separate multiple contact IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/2712221.html">ListContact</a> operation to obtain the ID of a contact from the <b>ContactId</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9957285,12067351,12304338,12342649</para>
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// <para>The ID of the deployment task. You can call the <a href="https://help.aliyun.com/document_detail/2712234.html">CreateDeploymentJob</a> operation to obtain the ID of a deployment task from the JobId parameter. You can also call the <a href="https://help.aliyun.com/document_detail/2712223.html">ListDeploymentJob</a> operation to obtain the ID of a deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The name of the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource. Separate multiple resource IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/2712230.html">ListCloudResources</a> operation to obtain the ID of a cloud resource from the <b>Id</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9957285,12067351,12304338,12342649</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The time when the task starts. The value is a UNIX timestamp. If you do not specify this parameter, the system immediately starts the task after it is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1606482979000</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

    }

}
