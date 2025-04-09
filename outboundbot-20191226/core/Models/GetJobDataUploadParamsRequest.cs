// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetJobDataUploadParamsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SCRIPT_RECORDING</para>
        /// </summary>
        [NameInMap("BusiType")]
        [Validation(Required=false)]
        public string BusiType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4eee9bf8-1319-468f-ac82-83c50ae389f8</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>//airwaybill/1237185904146124802</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sas_siema_1477832102462645_siem_f07e90c2c147cf8cf1549ccb974e1956</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

    }

}
