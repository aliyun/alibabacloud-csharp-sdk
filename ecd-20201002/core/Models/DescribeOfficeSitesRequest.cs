// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeOfficeSitesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42f6645a-9c3c-4772-be2a-cc5f5732****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public List<string> OfficeSiteId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
