// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow IMM to perform classification tasks on files in the dataset. Default value: False.</para>
        /// </summary>
        [NameInMap("AutoClustering")]
        [Validation(Required=false)]
        public bool? AutoClustering { get; set; }

        /// <summary>
        /// <para>Indicates whether IMM is allowed to perform automatic creation of new groups. Default value: False.</para>
        /// </summary>
        [NameInMap("AutoGenerate")]
        [Validation(Required=false)]
        public bool? AutoGenerate { get; set; }

        /// <summary>
        /// <para>The features supported by figure clustering.</para>
        /// </summary>
        [NameInMap("EnabledFeatures")]
        [Validation(Required=false)]
        public List<string> EnabledFeatures { get; set; }

        /// <summary>
        /// <para>The minimum threshold for the number of entities when automatic generation of new groups is allowed. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinEntityCount")]
        [Validation(Required=false)]
        public long? MinEntityCount { get; set; }

    }

}
