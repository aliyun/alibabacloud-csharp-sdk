// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The live streaming domain for which you want to modify the acceleration region.</para>
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
        /// <para>The acceleration region. A value of {&quot;coverage&quot;:&quot;overseas&quot;} specifies that the configuration is for regions outside mainland China. The following list describes the valid values for coverage:</para>
        /// <list type="bullet">
        /// <item><description><para>domestic: mainland China.</para>
        /// </description></item>
        /// <item><description><para>overseas: regions outside mainland China.</para>
        /// </description></item>
        /// <item><description><para>global: regions in and outside mainland China.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;coverage&quot;:&quot;global&quot;}</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
