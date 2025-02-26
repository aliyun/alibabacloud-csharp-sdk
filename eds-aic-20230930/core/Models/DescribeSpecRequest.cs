// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSpecRequest : TeaModel {
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

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
