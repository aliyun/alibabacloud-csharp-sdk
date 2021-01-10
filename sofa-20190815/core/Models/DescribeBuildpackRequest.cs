// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeBuildpackRequest : TeaModel {
        [NameInMap("BuildCommand")]
        [Validation(Required=false)]
        public string BuildCommand { get; set; }

        [NameInMap("CreationTimeFrom")]
        [Validation(Required=false)]
        public string CreationTimeFrom { get; set; }

        [NameInMap("CreationTimeTo")]
        [Validation(Required=false)]
        public string CreationTimeTo { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Descend")]
        [Validation(Required=false)]
        public bool? Descend { get; set; }

        [NameInMap("FullVersion")]
        [Validation(Required=false)]
        public string FullVersion { get; set; }

        [NameInMap("IsProcessed")]
        [Validation(Required=false)]
        public bool? IsProcessed { get; set; }

        [NameInMap("ModificationTimeFrom")]
        [Validation(Required=false)]
        public string ModificationTimeFrom { get; set; }

        [NameInMap("ModificationTimeTo")]
        [Validation(Required=false)]
        public string ModificationTimeTo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PublicationTimeFrom")]
        [Validation(Required=false)]
        public string PublicationTimeFrom { get; set; }

        [NameInMap("PublicationTimeTo")]
        [Validation(Required=false)]
        public string PublicationTimeTo { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("CreatedFromsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatedFromsRepeatList { get; set; }

        [NameInMap("CreatorIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> CreatorIdsRepeatList { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("PublisherIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> PublisherIdsRepeatList { get; set; }

        [NameInMap("ScopesRepeatList")]
        [Validation(Required=false)]
        public List<string> ScopesRepeatList { get; set; }

        [NameInMap("StatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> StatusesRepeatList { get; set; }

        [NameInMap("SupportedOsIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> SupportedOsIdsRepeatList { get; set; }

        [NameInMap("SupportedRegionIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> SupportedRegionIdsRepeatList { get; set; }

        [NameInMap("TechstackIdsRepeatList")]
        [Validation(Required=false)]
        public List<int?> TechstackIdsRepeatList { get; set; }

        [NameInMap("TechstackNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> TechstackNamesRepeatList { get; set; }

    }

}
