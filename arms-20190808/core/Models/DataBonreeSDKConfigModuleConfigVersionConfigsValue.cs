// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DataBonreeSDKConfigModuleConfigVersionConfigsValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether the custom configuration is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("useCustom")]
        [Validation(Required=false)]
        public bool? UseCustom { get; set; }

        /// <summary>
        /// <para>The custom configuration.</para>
        /// </summary>
        [NameInMap("customConfig")]
        [Validation(Required=false)]
        public Dictionary<string, DataBonreeSDKConfigModuleConfigVersionConfigsValueCustomConfigValue> CustomConfig { get; set; }

        /// <summary>
        /// <para>The description of the version configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the version configuration was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721112372055</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
