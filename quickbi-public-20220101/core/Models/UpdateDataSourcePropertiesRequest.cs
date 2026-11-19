// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateDataSourcePropertiesRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssss</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AAB95D-*****-****-*4FC0C976</para>
        /// </summary>
        [NameInMap("DsId")]
        [Validation(Required=false)]
        public string DsId { get; set; }

        /// <summary>
        /// <para>The owner of the data source. Set this parameter to the user ID in Quick BI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sss</para>
        /// </summary>
        [NameInMap("QuickBIOwnerId")]
        [Validation(Required=false)]
        public string QuickBIOwnerId { get; set; }

        /// <summary>
        /// <para>The display name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wls</para>
        /// </summary>
        [NameInMap("ShowName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

    }

}
