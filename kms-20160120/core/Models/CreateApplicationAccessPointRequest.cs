// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateApplicationAccessPointRequest : TeaModel {
        /// <summary>
        /// <para>The authentication method. Currently, only ClientKey is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientKey</para>
        /// </summary>
        [NameInMap("AuthenticationMethod")]
        [Validation(Required=false)]
        public string AuthenticationMethod { get; set; }

        /// <summary>
        /// <para>The description of the AAP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aap description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the AAP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aap_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The permission policy.</para>
        /// <remarks>
        /// <para>You can bind up to three permission policies to each AAP.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;kst-hzz62ee817bvyyr5x****.efkd&quot;,&quot;kst-hzz62ee817bvyyr5x****.eyyp&quot;]</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

    }

}
