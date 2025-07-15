// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The domain name for which you want to modify the acceleration region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The acceleration region that you want to set. {&quot;coverage&quot;:&quot;overseas&quot;} specifies regions outside the Chinese mainland. Valid values of coverage:</para>
        /// <list type="bullet">
        /// <item><description>domestic: regions in the Chinese mainland.</description></item>
        /// <item><description>overseas: regions outside the Chinese mainland.</description></item>
        /// <item><description>global: regions in and outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;coverage&quot;:&quot;global&quot;}</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
