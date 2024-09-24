// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateImageVulRequest : TeaModel {
        /// <summary>
        /// <para>The information about the vulnerability. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>namespace: the namespace of the image</description></item>
        /// <item><description>repoName: the name of the Container Registry repository</description></item>
        /// <item><description>regionId: the region ID</description></item>
        /// <item><description>instanceId: the ID of the Container Registry instance</description></item>
        /// <item><description>repoId: the name of the repository</description></item>
        /// <item><description>tag: the tad added to the image</description></item>
        /// <item><description>digest: the digest of the image</description></item>
        /// <item><description>newTag: the tag added to the image after the vulnerability is fixed</description></item>
        /// <item><description>uuid: the UUID of the image</description></item>
        /// <item><description>ids: the IDs of the vulnerability primary keys</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;namespace\&quot;:\&quot;cloud_oa****\&quot;,\&quot;repoName\&quot;:\&quot;hybirdc****\&quot;,\&quot;regionId\&quot;:\&quot;cn-shanghai\&quot;,\&quot;instanceId\&quot;:\&quot;cri-rv4nvbv8iju4****\&quot;,\&quot;repoId\&quot;:\&quot;crr-2q7302qrofxg****\&quot;,\&quot;tag\&quot;:\&quot;hybird-cloud-web_fix_167115945****\&quot;,\&quot;digest\&quot;:\&quot;e1a4fd25884ca2ef8840bb252c9926e4f549df9e046500dd93539b2d458c****\&quot;,\&quot;newTag\&quot;:\&quot;hybird-cloud-web_fix_167115996****\&quot;,\&quot;uuid\&quot;:\&quot;4ad91dd8c0c02de6574fa98085d0****\&quot;,\&quot;ids\&quot;:[197540864,197540865,197540869]}]</para>
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// <para>If you want to fix the vulnerability, set the value to vul_fix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Set the value to cve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
