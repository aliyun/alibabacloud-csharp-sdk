// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterStreamUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <para>If you create a production studio through the <a href="~~69338#doc-api-live-CreateCaster~~">CreateCaster</a> interface, check the value of the CasterId parameter in the response.</para>
        /// <para>If you create a production studio through the ApsaraVideo Live Console, log in to the console, then check the ID of the production studio through the following path:</para>
        /// <para>Production Studios &gt; Production Studio Management</para>
        /// <remarks>
        /// <para> The CasterId is reflected in the Name column on the Production Studio Management page.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
