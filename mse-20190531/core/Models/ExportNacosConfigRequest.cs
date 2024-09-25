// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ExportNacosConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qjl-gateway-openapi</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AppName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the data that you want to export.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Multiple export methods are supported.</para>
        /// </description></item>
        /// <item><description><para>If you want to export a single configuration, you must leave the Ids parameter empty and specify the DataID and Group parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sms-mes-develop.prop****</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The configuration group name and the ID of the configuration that you want to export. Separate multiple configurations with comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup+testDataId1,testGroup+testDataId2</para>
        /// </summary>
        [NameInMap("DataIds")]
        [Validation(Required=false)]
        public string DataIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the configuration group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIMEDTASK_COMMON_GROUP</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        [Obsolete]
        public string Group { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the primary key of a configuration item.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Multiple export methods are supported. You must specify this parameter if you want to export multiple configurations. - You can obtain the value of this parameter by calling the ListNacosConfigs operation. - If you specify this parameter, multiple configurations are exported. The DataId and Group parameters are invalid.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1709,1710</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-2r42ddc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae77c258-4d4f-478f-baaa-084aee0****</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
