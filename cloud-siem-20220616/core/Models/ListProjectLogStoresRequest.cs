// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListProjectLogStoresRequest : TeaModel {
        /// <summary>
        /// <para>The region of the Data Management center for threat analysis. Specify the region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets are in regions outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The code of the log to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_aegis_proc</para>
        /// </summary>
        [NameInMap("SourceLogCode")]
        [Validation(Required=false)]
        public string SourceLogCode { get; set; }

        /// <summary>
        /// <para>The code of the product to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("SourceProdCode")]
        [Validation(Required=false)]
        public string SourceProdCode { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123XXXXXXXX</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
