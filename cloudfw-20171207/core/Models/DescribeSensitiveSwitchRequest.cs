// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSensitiveSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The name of the category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Identity card</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>universal_industry_template</para>
        /// </summary>
        [NameInMap("ParentCategory")]
        [Validation(Required=false)]
        public string ParentCategory { get; set; }

        /// <summary>
        /// <para>The type of the sensitive credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_card</para>
        /// </summary>
        [NameInMap("SensitiveCategory")]
        [Validation(Required=false)]
        public string SensitiveCategory { get; set; }

        /// <summary>
        /// <para>The sensitivity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S3</para>
        /// </summary>
        [NameInMap("SensitiveLevel")]
        [Validation(Required=false)]
        public string SensitiveLevel { get; set; }

        /// <summary>
        /// <para>The status of the sensitive data detection switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public string SwitchStatus { get; set; }

    }

}
