// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceDTSParameters : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dts-cn-shanghai-vpc.com:18003</para>
        /// </summary>
        [NameInMap("BrokerUrl")]
        [Validation(Required=false)]
        public string BrokerUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1677340805</para>
        /// </summary>
        [NameInMap("InitCheckPoint")]
        [Validation(Required=false)]
        public int? InitCheckPoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dtsTest123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dtse34j22j025a****</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e34z2gm325q****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn_shanghai_vpc_rm_uf6398ykj0218****_dts_trigger_upgrade_from_old_version2</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dts_trigger</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
