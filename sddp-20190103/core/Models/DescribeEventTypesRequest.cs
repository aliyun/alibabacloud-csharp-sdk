// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the parent anomalous activity type to which the child anomalous activity type belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>01</b>: anomalous permission access.</para>
        /// </description></item>
        /// <item><description><para><b>02</b>: anomalous data flow.</para>
        /// </description></item>
        /// <item><description><para><b>03</b>: anomalous data operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("ParentTypeId")]
        [Validation(Required=false)]
        public long? ParentTypeId { get; set; }

        /// <summary>
        /// <para>The resource type of the product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: AnalyticDB for MySQL.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Tablestore.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>. ApsaraDB RDS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public int? ResourceId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: active.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: inactive.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
