// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusUserSettingRequest : TeaModel {
        /// <summary>
        /// <para>The value of the user setting.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("settingValue")]
        [Validation(Required=false)]
        public string SettingValue { get; set; }

    }

}
