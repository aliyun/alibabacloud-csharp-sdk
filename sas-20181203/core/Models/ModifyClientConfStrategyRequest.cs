// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientConfStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The client configuration tag.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>machineResource</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The extended tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("TagExt")]
        [Validation(Required=false)]
        public string TagExt { get; set; }

        /// <summary>
        /// <para>The client tag value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>major</description></item>
        /// <item><description>advanced</description></item>
        /// <item><description>basic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

        /// <summary>
        /// <para>The UUID of the asset to query. You must specify at least one of the Uuid and Uuids parameters. Otherwise, the API returns a 400 error. The Uuid parameter specifies a single asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The UUIDs of asset instances. A maximum of 500 UUIDs can be specified at a time. You must specify at least one of the Uuids and Uuid parameters. Otherwise, the API returns a 400 error. The Uuids parameter specifies multiple assets in a batch.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
