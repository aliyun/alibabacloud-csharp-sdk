// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckScopeConfigInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The UUIDs of the cloud assets to add.</para>
        /// </summary>
        [NameInMap("AddAssetUuids")]
        [Validation(Required=false)]
        public List<string> AddAssetUuids { get; set; }

        /// <summary>
        /// <para>The ID of the scan scope configuration. You can call the <a href="~~GetCheckScopeConfig~~">GetCheckScopeConfig</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00cfa8161da093089e6804ba6a33****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The UUIDs of the cloud assets to delete.</para>
        /// </summary>
        [NameInMap("DeleteAssetUuids")]
        [Validation(Required=false)]
        public List<string> DeleteAssetUuids { get; set; }

        /// <summary>
        /// <para>The cross-page select-all key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b6d1a39a-f020-4782-af2c-c4b6522*****</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

    }

}
