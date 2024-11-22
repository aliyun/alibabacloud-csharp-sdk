// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the contact.</para>
        /// </summary>
        [NameInMap("CasContacts")]
        [Validation(Required=false)]
        public List<DescribeDeploymentJobResponseBodyCasContacts> CasContacts { get; set; }
        public class DescribeDeploymentJobResponseBodyCasContacts : TeaModel {
            /// <summary>
            /// <para>The email address of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3304</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****0000</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The name of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The domain names bound to the certificate of the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com,demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("CertDomain")]
        [Validation(Required=false)]
        public string CertDomain { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: uploaded certificate</description></item>
        /// <item><description><b>buy</b>: purchased certificate</description></item>
        /// <item><description><b>free</b>: free certificate available only on the China site (aliyun.com)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>buy</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The configurations of the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;shareCertIds\&quot;:[],\&quot;certIds\&quot;:[12342649,12304338,12067351,9957285]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Indicates whether the deployment job was deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not deleted</description></item>
        /// <item><description><b>1</b>: deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Del")]
        [Validation(Required=false)]
        public int? Del { get; set; }

        /// <summary>
        /// <para>The end time of the deployment job. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679541809000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time when the deployment job was created. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679541809000</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the deployment job was last modified. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679541809000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the deployment job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The instance ID of the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14dcc8afc7578e1f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the deployment job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b>: multi-cloud deployment job.</description></item>
        /// <item><description><b>trustee</b>: hosted deployment job available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>user</b>: cloud service deployment job. The cloud server is not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The name of the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto-test-AXX</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The cloud services included in the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDN</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the deployment job includes the rollback worker. For example, if a cloud service in a deployment job has been rolled back, <b>1</b> is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The rollback worker is not included.</description></item>
        /// <item><description><b>1</b>: The rollback worker is included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rollback")]
        [Validation(Required=false)]
        public int? Rollback { get; set; }

        /// <summary>
        /// <para>The time when the deployment job was scheduled. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1678083209335</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// <para>The start time of the deployment job. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679541809000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the deployment job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pending</b></description></item>
        /// <item><description><b>editing</b></description></item>
        /// <item><description><b>scheduling</b></description></item>
        /// <item><description><b>processing</b></description></item>
        /// <item><description><b>error</b></description></item>
        /// <item><description><b>success</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>editing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account in which the deployment job is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166688437XXXX785</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
