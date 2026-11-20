// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVerifyContentRequest : TeaModel {
        /// <summary>
        /// <para>The access source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>share</b>: public cloud CNAME access</para>
        /// </description></item>
        /// <item><description><para><b>asset</b>: custom asset access</para>
        /// </description></item>
        /// <item><description><para><b>hybrid_cloud_cname</b>: hybrid cloud CNAME access</para>
        /// </description></item>
        /// <item><description><para><b>tgw</b>: cloud native mode</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("AccessOrigin")]
        [Validation(Required=false)]
        public string AccessOrigin { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance. You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
