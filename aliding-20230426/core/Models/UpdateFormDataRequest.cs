// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateFormDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBKTxxx</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM_INxxx</para>
        /// </summary>
        [NameInMap("FormInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexxxx</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UpdateFormDataJson")]
        [Validation(Required=false)]
        public string UpdateFormDataJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseLatestVersion")]
        [Validation(Required=false)]
        public bool? UseLatestVersion { get; set; }

    }

}
