// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DataProductListLogMapValue : TeaModel {
        /// <summary>
        /// <para>The log code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_config_log</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit log</para>
        /// </summary>
        [NameInMap("LogName")]
        [Validation(Required=false)]
        public string LogName { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit log</para>
        /// </summary>
        [NameInMap("LogNameEn")]
        [Validation(Required=false)]
        public string LogNameEn { get; set; }

        /// <summary>
        /// <para>The language code of the log, which is used to display multilingual names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${sas.cloudsiem.prod.cloud_siem_aegis_crack_from_beaver}</para>
        /// </summary>
        [NameInMap("LogNameKey")]
        [Validation(Required=false)]
        public string LogNameKey { get; set; }

        /// <summary>
        /// <para>The log delivery status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Delivery is in progress.  </description></item>
        /// <item><description>false: Delivery is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>Specifies whether the log delivery switch can be operated. Only the delegated administrator of Threat Analysis can operate the log delivery switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The switch can be operated.  </description></item>
        /// <item><description>false: The switch cannot be operated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanOperateOrNot")]
        [Validation(Required=false)]
        public bool? CanOperateOrNot { get; set; }

        /// <summary>
        /// <para>The topic of the log in the Logstore. It is an index field of the Logstore and can be used to distinguish different logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_login_event</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The extended parameters.</para>
        /// </summary>
        [NameInMap("ExtraParameters")]
        [Validation(Required=false)]
        public List<DataProductListLogMapValueExtraParameters> ExtraParameters { get; set; }
        public class DataProductListLogMapValueExtraParameters : TeaModel {
            /// <summary>
            /// <para>The identifier of the extended parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flag</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the extended parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
