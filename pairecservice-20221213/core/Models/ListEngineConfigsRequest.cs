// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListEngineConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Daily</b>: the development and test environment.</para>
        /// </description></item>
        /// <item><description><para><b>Pre</b>: the pre-production environment.</para>
        /// </description></item>
        /// <item><description><para><b>Prod</b>: the production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_config_v1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status to filter by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Released</b>: returns only released configurations.</para>
        /// </description></item>
        /// <item><description><para><b>Unreleased</b>: returns only unreleased configurations.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Released</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version to filter by.</para>
        /// <para>Set this parameter to <c>latest</c> to retrieve the most recently updated version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
