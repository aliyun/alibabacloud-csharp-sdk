// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceRegistrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The review comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment message</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The review details.</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public GetServiceRegistrationResponseBodyDetail Detail { get; set; }
        public class GetServiceRegistrationResponseBodyDetail : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service has risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AtRisk")]
            [Validation(Required=false)]
            public bool? AtRisk { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is associated with an artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasRelatedArtifact")]
            [Validation(Required=false)]
            public bool? HasRelatedArtifact { get; set; }

            /// <summary>
            /// <para>The review reports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;template&quot;:&quot;<a href="https://compute-nest-security-audit-bucket.oss-cn-hangzhou.aliyuncs.com/report">https://compute-nest-security-audit-bucket.oss-cn-hangzhou.aliyuncs.com/report</a>&quot; }</para>
            /// </summary>
            [NameInMap("Reports")]
            [Validation(Required=false)]
            public string Reports { get; set; }

            /// <summary>
            /// <para>The URL to view the differences in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://compute-nest-template-diff-bucket.oss-cn-hangzhou.aliyuncs.com/service-abc/diff">https://compute-nest-template-diff-bucket.oss-cn-hangzhou.aliyuncs.com/service-abc/diff</a></para>
            /// </summary>
            [NameInMap("TemplateDiffUrl")]
            [Validation(Required=false)]
            public string TemplateDiffUrl { get; set; }

        }

        /// <summary>
        /// <para>The time when the review was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T11:05:50Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The ID of the review request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sr-1b4aabc1c9eb4109****</para>
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A361BA9E-xxxx-xxxx-xxxx-C26E5180456E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-c2d118c9193e49xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service details.</para>
        /// </summary>
        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public GetServiceRegistrationResponseBodyServiceInfo ServiceInfo { get; set; }
        public class GetServiceRegistrationResponseBodyServiceInfo : TeaModel {
            /// <summary>
            /// <para>The service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The trial type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Trial: The service supports trial.</para>
            /// </description></item>
            /// <item><description><para>NotTrial: The service does not support trial.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trial</para>
            /// </summary>
            [NameInMap("TrialType")]
            [Validation(Required=false)]
            public string TrialType { get; set; }

            /// <summary>
            /// <para>The version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The status of the review request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Submitted</para>
        /// </description></item>
        /// <item><description><para>Approved</para>
        /// </description></item>
        /// <item><description><para>Rejected</para>
        /// </description></item>
        /// <item><description><para>Canceled</para>
        /// </description></item>
        /// <item><description><para>Executed: The service version is published.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Submitted</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the request was submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T11:05:50Z</para>
        /// </summary>
        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

    }

}
