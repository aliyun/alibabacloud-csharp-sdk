// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class PublishGrayDomainConfigRequest : TeaModel {
        [NameInMap("CustomCountryId")]
        [Validation(Required=false)]
        public int? CustomCountryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("CustomPercent")]
        [Validation(Required=false)]
        public int? CustomPercent { get; set; }

        [NameInMap("CustomProvinceId")]
        [Validation(Required=false)]
        public int? CustomProvinceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publishByCustom</para>
        /// </summary>
        [NameInMap("PublishMode")]
        [Validation(Required=false)]
        public string PublishMode { get; set; }

    }

}
