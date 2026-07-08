// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class AddCloudAccessRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service provider. This API supports multiple providers as detailed in the SecretKey parameter description. For example, to add credentials for Tencent Cloud, set this parameter to <b>Tencent</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("CloudName")]
        [Validation(Required=false)]
        public string CloudName { get; set; }

        /// <summary>
        /// <para>The Secret ID for accessing the cloud resource set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcxx</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The secret corresponding to the AccessKey. The value is determined by the <c>AkType</c> parameter as follows:</para>
        /// <para>1\. If <c>AkType</c> is set to <c>primary</c>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Tencent</b>: The SecretAccessKey of the primary account.</para>
        /// </description></item>
        /// <item><description><para><b>HUAWEI CLOUD</b>: The SecretAccessKey of the primary account.</para>
        /// </description></item>
        /// <item><description><para><b>Azure</b>: The ClientSecret.</para>
        /// </description></item>
        /// <item><description><para><b>AWS</b>: The SecretAccessKey of the primary account.</para>
        /// </description></item>
        /// </list>
        /// <para>2\. If <c>AkType</c> is set to <c>sub</c>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Tencent</b>: The SecretAccessKey of the sub-account.</para>
        /// </description></item>
        /// <item><description><para><b>HUAWEI CLOUD</b>: The SecretAccessKey of the sub-account.</para>
        /// </description></item>
        /// <item><description><para><b>Azure</b>: The ClientSecret.</para>
        /// </description></item>
        /// <item><description><para><b>AWS</b>: The SecretAccessKey of the sub-account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

    }

}
