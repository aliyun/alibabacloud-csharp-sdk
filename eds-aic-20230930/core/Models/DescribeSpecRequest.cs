// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSpecRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The matrix specification.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpm.gn6.gx1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpm.gn6.gx1</para>
        /// </summary>
        [NameInMap("MatrixSpec")]
        [Validation(Required=false)]
        public string MatrixSpec { get; set; }

        /// <summary>
        /// <para>The maximum number of items to return per page in a paginated query. The value range is 1 to 100, with a default value of 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the starting position for reading. If left empty, it starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uONHqPtDLM2U8s****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The purchase mode of cloud mobile phones.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance (default): the instance group mode.</description></item>
        /// <item><description>Node: the matrix mode [whitelisted].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>List of specification IDs.</para>
        /// </summary>
        [NameInMap("SpecIds")]
        [Validation(Required=false)]
        public List<string> SpecIds { get; set; }

        /// <summary>
        /// <para>Specification status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("SpecStatus")]
        [Validation(Required=false)]
        public string SpecStatus { get; set; }

        /// <summary>
        /// <para>Specification type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ARM</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
