// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesRequest : TeaModel {
        [NameInMap("AICSpecs")]
        [Validation(Required=false)]
        public List<string> AICSpecs { get; set; }

        [NameInMap("DescribeAICInstances")]
        [Validation(Required=false)]
        public bool? DescribeAICInstances { get; set; }

        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        [NameInMap("LatestAction")]
        [Validation(Required=false)]
        public string LatestAction { get; set; }

        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public List<string> ServerIds { get; set; }

        [NameInMap("ServerSpecs")]
        [Validation(Required=false)]
        public List<string> ServerSpecs { get; set; }

        [NameInMap("States")]
        [Validation(Required=false)]
        public List<string> States { get; set; }

    }

}
