// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstanceSourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the security audit feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether DSC is authorized to access the data asset.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-demo-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese (default)</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service to which the data asset to query belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: Object Storage Service (OSS)</description></item>
        /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
        /// <item><description><b>4</b>: Tablestore (OTS)</description></item>
        /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
        /// <item><description><b>6</b>: self-managed databases</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The content based on which a fuzzy search is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The data asset type based on which a fuzzy search is performed.</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: the ID of the instance.</description></item>
        /// <item><description><b>InstanceName</b>: the name of the instance.</description></item>
        /// <item><description><b>DatabaseName</b>: the name of the database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>The region in which the data asset resides. For more information, see <a href="https://help.aliyun.com/document_detail/214257.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}
