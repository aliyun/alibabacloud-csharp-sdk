// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateInstanceBindNumberRequest : TeaModel {
        /// <summary>
        /// <para>List of outbound calling instance IDs.</para>
        /// <remarks>
        /// <para>Modifying this parameter overwrites previous parameters. Setting this parameter to empty clears the number binding list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90515b5-6115-4ccf-83e2-52d5bfaf2ddf
        /// ,123<em><b><b>09,456</b></b></em>08</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

        /// <summary>
        /// <para>The number to bind (required).</para>
        /// <remarks>
        /// <para>For the list of numbers, see the Number parameter returned by the ListAllTenantBindNumberBinding API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15005059355</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
