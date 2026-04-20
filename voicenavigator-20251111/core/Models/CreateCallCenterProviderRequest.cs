// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateCallCenterProviderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>153*********</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key1=value1</para>
        /// </summary>
        [NameInMap("Extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>010****</para>
        /// </summary>
        [NameInMap("Originator")]
        [Validation(Required=false)]
        public string Originator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCC</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ReferTo")]
        [Validation(Required=false)]
        public string ReferTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trunk-xxx</para>
        /// </summary>
        [NameInMap("TrunkId")]
        [Validation(Required=false)]
        public string TrunkId { get; set; }

    }

}
