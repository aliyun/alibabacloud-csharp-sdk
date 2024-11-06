// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGeoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The language of the information to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
