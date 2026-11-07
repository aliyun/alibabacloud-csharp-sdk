// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNacosConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fpx-pds-pns</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The data ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zeekr-*</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The group type. Default value: <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-7mz2fj****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fad732a7-ff1a-4f21-8126-4edd4****</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the cluster is located. Only regions supported by Microservices Engine (MSE) are valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The extended request parameters. JSON format is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appGroup\&quot;:\&quot;sm_zk_asi_na610\&quot;,\&quot;appName\&quot;:\&quot;sm-zk\&quot;,\&quot;appStage\&quot;:\&quot;PUBLISH\&quot;,\&quot;appUnit\&quot;:\&quot;center\&quot;,\&quot;bucId\&quot;:\&quot;193554\&quot;,\&quot;bucName\&quot;:\&quot;Alibaba Mobile Business Group-UC\&quot;,\&quot;provider\&quot;:\&quot;aliyun\&quot;}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>billing</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
