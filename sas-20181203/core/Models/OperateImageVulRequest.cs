// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateImageVulRequest : TeaModel {
        /// <summary>
        /// <para>The information about the vulnerability to be processed. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>namespace: the image namespace.</description></item>
        /// <item><description>repoName: the name of the ACR image repository.</description></item>
        /// <item><description>regionId: the region.</description></item>
        /// <item><description>instanceId: the ID of the ACR instance.</description></item>
        /// <item><description>repoId: the ID of the repository.</description></item>
        /// <item><description>tag: the original tag of the image.</description></item>
        /// <item><description>digest: the digest of the image.</description></item>
        /// <item><description>newTag: the tag of the image after the fix.</description></item>
        /// <item><description>uuid: the UUID of the image.</description></item>
        /// <item><description>ids: the list of primary key IDs of the vulnerabilities.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;namespace\&quot;:\&quot;cloud_oa****\&quot;,\&quot;repoName\&quot;:\&quot;hybirdc****\&quot;,\&quot;regionId\&quot;:\&quot;cn-shanghai\&quot;,\&quot;instanceId\&quot;:\&quot;cri-rv4nvbv8iju4****\&quot;,\&quot;repoId\&quot;:\&quot;crr-2q7302qrofxg****\&quot;,\&quot;tag\&quot;:\&quot;hybird-cloud-web_fix_167115945****\&quot;,\&quot;digest\&quot;:\&quot;e1a4fd25884ca2ef8840bb252c9926e4f549df9e046500dd93539b2d458c****\&quot;,\&quot;newTag\&quot;:\&quot;hybird-cloud-web_fix_167115996****\&quot;,\&quot;uuid\&quot;:\&quot;4ad91dd8c0c02de6574fa98085d0****\&quot;,\&quot;ids\&quot;:[197540864,197540865,197540869]}]</para>
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// <para>The operation type for image vulnerability fix. Set this parameter to vul_fix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The vulnerability type. Set this parameter to cve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
