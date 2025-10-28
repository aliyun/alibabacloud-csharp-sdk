// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertOrUpdateRegionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable remote debugging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables remote debugging.</description></item>
        /// <item><description>false: disables remote debugging.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DebugEnable")]
        [Validation(Required=false)]
        public bool? DebugEnable { get; set; }

        /// <summary>
        /// <para>The description of the namespace. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to create or modify the namespace. If this parameter is left empty or is set to 0, the namespace is created. Otherwise, the namespace is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the MSE registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-tl32n******</para>
        /// </summary>
        [NameInMap("MseInstanceId")]
        [Validation(Required=false)]
        public string MseInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace. The name can be up to 63 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_region</para>
        /// </summary>
        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <list type="bullet">
        /// <item><description>The ID of a custom namespace is in the <c>Region ID:Namespace identifier</c> format. Example: cn-beijing:tdy218.</description></item>
        /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: cn-beijing.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        /// <summary>
        /// <para>The type of the registry.</para>
        /// <list type="bullet">
        /// <item><description>default: the shared registry of Enterprise Distributed Application Service (EDAS)</description></item>
        /// <item><description>exclusive_mse: a Microservices Engine (MSE) registry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
