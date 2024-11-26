// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj000112,cmgj000113</para>
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public string Codes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj000114,cmgj000115</para>
        /// </summary>
        [NameInMap("ExceptCodes")]
        [Validation(Required=false)]
        public string ExceptCodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
