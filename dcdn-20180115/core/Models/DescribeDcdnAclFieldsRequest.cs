// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnAclFieldsRequest : TeaModel {
        /// <summary>
        /// <para>The access language. Default value: en. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English</description></item>
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
